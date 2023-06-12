import { useFetchBlogPostsQuery } from '../store';
import { BlogPost } from '../types/BlogPosts';

export const BlogPostsList = () => {
  const { data, error, isLoading } = useFetchBlogPostsQuery({});
  console.log(data, error, isLoading);
  if (isLoading) {
    return <div className="border-x border-t rounded">Загрузка</div>;
  } else {
    return (
      <div className="border-x border-t rounded">
        {data.map((p: BlogPost) => {
          return <p key={p.id}>{p.title}</p>;
        })}
      </div>
    );
  }
};
