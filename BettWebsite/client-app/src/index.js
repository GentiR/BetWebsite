import React from 'react';
import ReactDOM from 'react-dom';
import indexRoutes from './routes/index.jsx';
import {  Route, Switch } from 'react-router-dom';
import { HashRouter } from 'react-router-dom';
import { ToastProvider } from "react-toast-notifications";


import './assets/scss/style.css';



ReactDOM.render(
  <HashRouter>
    <Switch>
    <ToastProvider>
      {indexRoutes.map((prop, key) => {
        return <Route path={prop.path} key={key} component={prop.component} />;
      })}
      </ToastProvider>
    </Switch>

  </HashRouter>
  ,document.getElementById('root')); 
