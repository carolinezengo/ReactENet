import React, { Component } from 'react';
import './styles.css';
import Formulario from '../../Componentes/Formulario/FormularioLogin';
import Lateral from '../../Componentes/Lateral/Lateral';


function Home() {
    return (
    
           
        <div className="linha">
            <div className="formulario">
                <Formulario />
                <div className="lateral">
                    <Lateral />
                </div>

            </div>
              
          
         
            
        </div>
         

         

            
          
                    
          
       );
    
}
export default Home;