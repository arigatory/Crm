using ApiService.Application.Features.Decorators;
using MediatR;
using System.Reflection;

namespace ApiService.Application;

internal class AttributeBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
{
    private readonly IRequestHandler<TRequest, TResponse> _requestHandler;

    public AttributeBehaviour(IRequestHandler<TRequest, TResponse> requestHandler)
    {
        _requestHandler = requestHandler;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        var type = _requestHandler.GetType();
        object[] attributes = type.GetCustomAttributes(false);

        List<Type> pipeline = attributes
            .Select(a => ToDecorator(a))
            .Concat(new[] { type })
            .Reverse()
            .ToList();

        Type interfaceType = type.GetInterfaces().Single(IsHandlerInterface);
        Func<IServiceProvider, object> factory = BuildPipeline(pipeline, interfaceType);

        var decoratedHandler = (IRequestHandler<TRequest, TResponse>)factory.Invoke(null);
        return await decoratedHandler.Handle(request, cancellationToken);
    }

    private static Func<IServiceProvider, object> BuildPipeline(List<Type> pipeline, Type interfaceType)
    {
        List<ConstructorInfo> ctors = pipeline
            .Select(x =>
            {
                Type type = x.IsGenericType ? x.MakeGenericType(interfaceType.GenericTypeArguments) : x;
                return type.GetConstructors().Single();
            })
            .ToList();

        Func<IServiceProvider, object> func = provider =>
        {
            object current = null;

            foreach (var ctor in ctors)
            {
                List<ParameterInfo> parameterInfos = ctor.GetParameters().ToList();

                object[] parameters = GetParameters(parameterInfos, current, provider);

                current = ctor.Invoke(parameters);
            }

            return current;
        };

        return func;
    }

    private static object[] GetParameters(List<ParameterInfo> parameterInfos, object current, IServiceProvider provider)
    {
        var result = new object[parameterInfos.Count];

        for (int i = 0; i < parameterInfos.Count; i++)
        {
            result[i] = GetParameter(parameterInfos[i], current, provider);
        }

        return result;
    }

    private static object GetParameter(ParameterInfo parameterInfo, object current, IServiceProvider provider)
    {
        Type parameterType = parameterInfo.ParameterType;

        if (IsHandlerInterface(parameterType))
            return current;

        object service = provider.GetService(parameterType);
        if (service != null)
            return service;

        throw new ArgumentException($"Type {parameterType} not found");
    }

    private static bool IsHandlerInterface(Type parameterType)
    {
        return parameterType.IsGenericType &&
               (parameterType.GetGenericTypeDefinition() == typeof(IRequestHandler<,>) ||
                parameterType.GetGenericTypeDefinition() == typeof(IRequestHandler<>));
    }

    private static IEnumerable<Type> GetDecorators(Type attributeType)
    {
        if (attributeType == typeof(LogAttribute))
        {
            yield return typeof(LogDecorator<>);
        }
        else if (attributeType == typeof(AuditAttribute))
        {
            yield return typeof(AuditDecorator<>);
        }
        // Add more attribute mappings here if needed
    }

    private static IEnumerable<Type> GetDecorators(object[] attributes)
    {
        foreach (var attribute in attributes)
        {
            Type attributeType = attribute.GetType();
            foreach (var decorator in GetDecorators(attributeType))
            {
                yield return decorator;
            }
        }
    }

    private static List<Type> GetPipeline(Type handlerType, object[] attributes)
    {
        var pipeline = new List<Type>();
        pipeline.AddRange(GetDecorators(attributes));
        pipeline.Add(handlerType);
        return pipeline;
    }

    private static Type ToDecorator(object attribute)
    {
        throw new NotSupportedException("This method should not be called");
    }

    private static Type ToDecorator(Type decoratorType, Type attributeType)
    {
        return decoratorType.MakeGenericType(attributeType);
    }

}



//internal class AttributeBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
//where TRequest : IRequest<TResponse>
//{
//    private readonly IRequestHandler<TRequest, TResponse> _requestHandler;

//    public AttributeBehaviour(IRequestHandler<TRequest, TResponse> requestHandler)
//    {
//        _requestHandler = requestHandler;
//    }
//    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
//        CancellationToken cancellationToken)
//    {
//        //var hasSqlTransactionAttribute = requestHandler.GetType().GetCustomAttributes<SqlTransactionAttribute>().Any();

//        //if (hasSqlTransactionAttribute)
//        //{
//        //    await HandleSqlTransaction(next);
//        //}
//        var type = _requestHandler.GetType();
//        object[] attributes = type.GetCustomAttributes(false);

//        List<Type> pipeline = attributes
//            .Select(a => ToDecorator(a))
//            .Concat(new[] { type })
//            .Reverse()
//            .ToList();

//        Type interfaceType = type.GetInterfaces().Single(y => IsHandlerInterface(y));
//        Func<IServiceProvider, object> factory = BuildPipeline(pipeline, interfaceType);


//        //_logger.LogInformation($"Handling {typeof(TRequest).Name}");
//        var response = await next();

//        //_logger.LogInformation($"Handled {typeof(TResponse).Name}");

//        return response;
//    }

//    private static Func<IServiceProvider, object> BuildPipeline(List<Type> pipeline, Type interfaceType)
//    {
//        List<ConstructorInfo> ctors = pipeline
//            .Select(x =>
//            {
//                Type type = x.IsGenericType ? x.MakeGenericType(interfaceType.GenericTypeArguments) : x;
//                return type.GetConstructors().Single();
//            })
//            .ToList();

//        Func<IServiceProvider, object> func = provider =>
//        {
//            object current = null;

//            foreach (var ctor in ctors)
//            {
//                List<ParameterInfo> parameterInfos = ctor.GetParameters().ToList();

//                object[] parameters = GetParameters(parameterInfos, current, provider);

//                current = ctor.Invoke(parameters);
//            }

//            return current;
//        };

//        return func;
//    }


//    private static object[] GetParameters(List<ParameterInfo> parameterInfos, object current, IServiceProvider provider)
//    {
//        var result = new object[parameterInfos.Count];

//        for (int i = 0; i < parameterInfos.Count; i++)
//        {
//            result[i] = GetParameter(parameterInfos[i], current, provider);
//        }

//        return result;
//    }

//    private static object GetParameter(ParameterInfo parameterInfo, object current, IServiceProvider provider)
//    {
//        Type parameterType = parameterInfo.ParameterType;

//        if (IsHandlerInterface(parameterType))
//            return current;

//        object service = provider.GetService(parameterType);
//        if (service != null)
//            return service;

//        throw new ArgumentException($"Тип {parameterType} не найден");
//    }

//    private static bool IsHandlerInterface(Type parameterType)
//    {
//        throw new NotImplementedException();
//    }

//    private static Type ToDecorator(object attribute)
//    {
//        Type type = attribute.GetType();

//        if (type == typeof(LogAttribute))
//            return typeof(LogDecorator<>);

//        if (type == typeof(LogAttribute))
//            return typeof(LogDecorator<>);

//        // другие атрибуты

//        throw new ArgumentNullException(attribute.ToString());
//    }
//}
