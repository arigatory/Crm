import { createSlice } from '@reduxjs/toolkit';

const blogPostsSlice = createSlice({
  name: 'blogPosts',
  initialState: {
    data: []
  },
  reducers: {}
});

export const blogPostsReducer = blogPostsSlice.reducer;