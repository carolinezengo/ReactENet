import './styles.css';
import { useState, useEffect } from 'react';
import React, { Component } from 'react';

let FormStateLogin = {
    email: '',
    senha: ''

};
function FormularioLogin() {

    const [login, setLogin] = useState(FormStateLogin);

    useEffect(() => {
        populateLogin();
    }, []);

    const handleChange = (event) => {
        const {name, value } = event.target;
        setLogin({ ...login,[name]: value });
       

    }

    const handleSubmit = (event) => {
        alert('Um nome foi enviado: ' + login.email);
        event.preventDefault();
        console.log(login);
    }

  
        return (
            <form onSubmit={handleSubmit}>
                <label htmlFor="task-email"> Email: </label>

                <input type="text" id="task-email" name="email " defaultValue={login.email} placeholder="Digite email"
                    onChange={handleChange} />

                <label htmlFor="task-senha"> Senha: </label>

                <input type="text" id="task-senha" name="senha"
                    defaultValue={login.senha}
                    placeholder="Digite senha"
                    onChange={handleChange} />

                <input type="submit" value="Enviar formulário!" />
            </form>
        );

    async function populateLogin() {
        const response = await fetch('usuario');
        if (response) {
            console.log("ok");
        }
        else
        console.log('....')
      
    }

}
export default FormularioLogin;