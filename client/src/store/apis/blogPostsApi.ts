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
        query: (blogPost: BlogPost) => {
          return {
            url: '/blog-posts',
            params: {
              blogPostsId: blogPost.id,
            },
            method: 'GET',
          };
        },
      }),
    };
  },
});
