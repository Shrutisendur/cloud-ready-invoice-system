import axios from "axios";

const api = axios.create({
  baseURL: "https://localhost:7000/api", // change port if needed
  headers: {
    "Content-Type": "application/json",
  },
});

// Attach JWT token automatically (later)
api.interceptors.request.use((config) => {
  const token = localStorage.getItem("token");
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

export default api;
