import React, { Component } from 'react';
import { BrowserRouter as Router, Routes, Route, Link, BrowserRouter } from 'react-router-dom';
import { FiSettngs } from 'react-icons/fi';
import { TooltipComponent } from '@syncfusion/ej2-react-popups';
import './App.css';


import Login from './components/login.component';
import SignUp from './components/register.component';


    export default function App() {
      return (
          <div>
            <BrowserRouter>
            <div className='underline text-center'>
                Hello world!
            </div>
            </BrowserRouter>
          </div>
        )
      }
  