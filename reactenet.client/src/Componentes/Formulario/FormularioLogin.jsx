import styles from "../Formulario/styles.module.scss"; 
import { useState, FormEvent } from 'react';
import React, { Component } from 'react';
import { useNavigate } from 'react-router-dom';

import axios from 'axios';


let FormStateLogin = {
    email1: ''
   

};
function FormularioLogin() {

   
    const [senhauser, setSenhalUser] = useState("");
    const [emailuser, setEmailUser] = useState("");
    const [usuarios, setUsuarios] = useState([]);
   

   
    async function populateLogin() {
        await axios.get(`api/usuario/`).then((response) => setUsuarios(response.data));

    };

  
    const navigate = useNavigate();
   
    const inciarAbout = () => {
        navigate('/about');
    }

    function handleSubmit(event) {
    
     alert('Um nome foi enviado: ' + emailuser);

        event.preventDefault();
        populateLogin();
       
     
        usuarios.forEach(function (usuario) {
            if (usuario.Email == emailuser && usuario.Senha == senhauser) {
                
                inciarAbout();
                console.log("email ");
               
            } else
                console.log("email nao cadastrado");
           
        });
           

       

    }
    const emailTeste = "";

    return (


        <section className={styles.container}>

            <form
              onSubmit={handleSubmit}>
                <div>
                    <label htmlFor="task-email"> Email: </label>

                    <input type="text"
                        id="task-email"
                        name="email "
                        value={emailuser}
                        placeholder="Digite email"
                        onChange={(event) => setEmailUser(event.target.value)} />

                    <label htmlFor="task-senha"> Senha: </label>

                    <input type="text"
                        id="task-senha"
                        name="senha"
                        value={senhauser}
                        placeholder="Digite senha"
                        onChange={(event) => setSenhalUser(event.target.value)} />
                    <button type="submit">Logar</button>


                </div>
              
                

               
            </form>

         </section>
      
    );
   
    

}    
    
export default FormularioLogin;