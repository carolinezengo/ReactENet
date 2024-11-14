import { StrictMode, createContext } from 'react';
import { createRoot } from 'react-dom/client';
import { createBrowserRouter, RouterProvider, } from "react-router-dom";
import Home from "../src/Pages/Home/Home"
import ErrorPage from "../src/Pages/ErrorPage/ErrorPage";
import './index.css';
import App from "./App";
import About from "../src/Pages/About/About"

const router = createBrowserRouter([
    {
        path: "/",
        element: <App />,
        errorElement: <ErrorPage />,
        children: [
            {
                path: "/",
                element: <Home/>,
            },
            {
                path: "about",
                element: <About />,
            },
        ],
    },
]);

createRoot(document.getElementById('root')).render(
    
    <StrictMode>

        <RouterProvider router={router} />
    
       
  </StrictMode>,
)
