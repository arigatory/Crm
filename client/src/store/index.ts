import { configureStore } from '@reduxjs/toolkit';
import { blogPostsReducer } from "./slices/blogPostsSlice";

export const store = configureStore({
  reducer: {
    blogPosts: blogPostsReducer
  }
});