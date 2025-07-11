import { create } from 'zustand';
import { persist, createJSONStorage } from 'zustand/middleware';
import AsyncStorage from '@react-native-async-storage/async-storage';

const API_BASE_URL = 'http://10.0.2.2:3000';

// Для iOS симулятора:
// const API_BASE_URL = 'http://localhost:3000';

export const useAuthStore = create(
  persist(
    (set, get) => ({
      user: null,
      token: null,
      isLoading: false,
      error: null,
      rememberMe: false,

      setRememberMe: (remember) => set({ rememberMe: remember }),

      login: async (email, password) => {
        set({ isLoading: true, error: null });
        try {
        
          const usersResponse = await fetch(`${API_BASE_URL}/users?email=${email}&password=${password}`);
          const users = await usersResponse.json();
          
          if (users.length === 0) {
            throw new Error('Invalid email or password');
          }
          

          const loginResponse = await fetch(`${API_BASE_URL}/login/1`);
          const data = await loginResponse.json();
          
          
          const userData = {
            ...data.user,
            email: users[0].email,
            firstName: users[0].firstName,
            lastName: users[0].lastName
          };
          
          set({
            user: userData,
            token: data.token,
            isLoading: false,
            error: null,
          });

          return { success: true, data: { ...data, user: userData } };
        } catch (error) {
          set({
            isLoading: false,
            error: error.message || 'Login failed',
          });
          return { success: false, error: error.message };
        }
      },

      register: async (userData) => {
        set({ isLoading: true, error: null });
        try {
        
          const existingUsers = await fetch(`${API_BASE_URL}/users?email=${userData.email}`);
          const users = await existingUsers.json();
          
          if (users.length > 0) {
            throw new Error('User with this email already exists');
          }
          
          
          const newUserResponse = await fetch(`${API_BASE_URL}/users`, {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify({
              ...userData,
              createdAt: new Date().toISOString(),
            }),
          });
          
          if (!newUserResponse.ok) {
            throw new Error('Failed to create user');
          }
          
          const newUser = await newUserResponse.json();
          
          
          const registerResponse = await fetch(`${API_BASE_URL}/register/1`);
          const data = await registerResponse.json();
          
          const userWithToken = {
            ...data.user,
            email: newUser.email,
            firstName: newUser.firstName,
            lastName: newUser.lastName
          };
          
          set({
            user: userWithToken,
            token: data.token,
            isLoading: false,
            error: null,
          });

          return { success: true, data: { ...data, user: userWithToken } };
        } catch (error) {
          set({
            isLoading: false,
            error: error.message || 'Registration failed',
          });
          return { success: false, error: error.message };
        }
      },

      logout: () => {
        set({
          user: null,
          token: null,
          error: null,
          rememberMe: false,
        });
      },

      clearError: () => set({ error: null }),

      isAuthenticated: () => {
        const { user, token } = get();
        return !!(user && token);
      },
    }),
    {
      name: 'auth-storage',
      storage: createJSONStorage(() => AsyncStorage),
      partialize: (state) => ({
        user: state.user,
        token: state.token,
        rememberMe: state.rememberMe,
      }),
    }
  )
);