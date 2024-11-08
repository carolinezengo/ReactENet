import React, { Component } from 'react';
import './styles.css';
import Login from '../Formulario/FormularioLogin';
import Lateral from '../Lateral/Lateral';


function Home() {
        return (
           
                <div className="container">
                    <Lateral />
                    <Login />

                </div>


           

        );
    
}
export default Home;