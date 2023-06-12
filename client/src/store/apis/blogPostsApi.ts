import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { BlogPost } from '../../types/BlogPosts';

const blogPostsApi = createApi({
  reducerPath: 'blogPosts',
  baseQuery: fetchBaseQuery({
    baseUrl: 'https://localhost:7298/api',
  }),
  endpoints(builder) {
    return {
      fetchBlogPosts: builder.query({
        query: () => {
          return {
            url: '/blog-posts',
            method: 'GET',
          };
        },
      }),
    };
  },
});

export const { useFetchBlogPostsQuery } = blogPostsApi;
export { blogPostsApi };