import { configureStore } from '@reduxjs/toolkit';
import { setupListeners } from '@reduxjs/toolkit/query';
import { blogPostsApi } from './apis/blogPostsApi';

export const store = configureStore({
  reducer: {
    [blogPostsApi.reducerPath]: blogPostsApi.reducer,
  },
  middleware: (getDefaultMiddleware) => {
    return getDefaultMiddleware().concat(blogPostsApi.middleware);
  },
});

setupListeners(store.dispatch);

export { useFetchBlogPostsQuery } from './apis/blogPostsApi';