import { useFetchBlogPostsQuery } from '../store';
import { BlogPost } from '../types/BlogPosts';

export const BlogPostsList = () => {
  const { data, error, isLoading } = useFetchBlogPostsQuery({});
  console.log(data, error, isLoading);
  if (isLoading) {
    return <div className="border-x border-t rounded">Загрузка</div>;
  } else {
    return (

      <div className="mt-6 space-y-12 lg:grid lg:grid-cols-3 lg:gap-x-6 lg:space-y-0">
        {data.map((callout: BlogPost) => (
          <div key={callout.id} className="group relative">
            <div className="relative h-80 w-full overflow-hidden rounded-lg bg-white sm:aspect-h-1 sm:aspect-w-2 lg:aspect-h-1 lg:aspect-w-1 group-hover:opacity-75 sm:h-64">
              <img
                src={callout.imageUrl}
                alt={callout.title}
                className="h-full w-full object-cover object-center"
              />
            </div>
            <h3 className="mt-6 text-sm text-gray-500">
              <a href={callout.id}>
                <span className="absolute inset-0" />
                {callout.title}
              </a>
            </h3>
            <p className="text-base font-semibold text-gray-900">{callout.content}</p>
          </div>
        ))}
      </div>

    );
  }
};
