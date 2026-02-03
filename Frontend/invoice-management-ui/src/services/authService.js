import axios from "axios";

const API_URL = "https://localhost:7029/api/Auth";

export const login = (data) => {
  return axios.post(`${API_URL}/login`, data);
};
