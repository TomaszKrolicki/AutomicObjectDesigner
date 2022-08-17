import React, { Component } from 'react';
import { useEffect } from 'react';
import { Router, Routes, Route, Link, BrowserRouter} from 'react-router-dom';
// import { BrowserRouter as Router, Routes, Route, Link, BrowserRouter } from 'react-router-dom';
import { FiSettings } from 'react-icons/fi';
import { TooltipComponent } from '@syncfusion/ej2-react-popups';
import './App.css';


import Login from './components/login.component';
import SignUp from './components/register.component';


    export default function App() {
      const activeMenu = false;
      return (
          <div>
            <BrowserRouter>
            <div className='flex relative dark:bg-main-dark-bg'>
              <div className='fixed right-4 bottom-4' style={{zIndex: '1000'}}>
                <TooltipComponent content="Settings" position="Top">
                  <button type='button'
                  className='text-3xl p-3
                  hover:drop-shadow-xl
                  hover:bg-light-gray text-white
                  '
                  style={{background:'blue',
                  borderRadius: '50%' }}>
                    <FiSettings />
                  </button>
                </TooltipComponent>
              </div>
                {activeMenu ? (
                  <div className='w-72 fixe sidebar
                  dark:bg-secondary-dark-bg
                  bg-white'>
                    Sidebar
                  </div>
                ) : (
                  <div className='w-0
                  dark:bg-secondary-dark-bg'>
                    Sidebar
                  </div>
                )}
                <div className={ `dark:bg-main-bg bg-main-bg 
                min-h-screen w-full
                  ${activeMenu ?
                  ' md:ml-72 ' : 'flex-2'}`
                }>
                  <div className='fixed md:static
                  bg-main-bg dark:bg-main-dark-bg
                  navbar w-full'>
                    Navbar
                  </div>
                </div>
                <Routes>
                  {/* Dashboard */}
                  <Route path='/' element="Ecommerce" />
                  <Route path='/ecommerce' 
                  element="Ecommerce" />
                  {/* Pages */}
                  <Route path='/sapjobsimple' element="SAPJobSimple" />
                  <Route path='/sapjobmassen' element="SAPJobMassen" />
                  <Route path='/sapjobbw ' element="SAPJobBW" />
                  <Route path='/windowsgeneral' element="WindowsGeneral" />
                  <Route path='/unixgeneral' element="UnixGeneral" />
                  <Route path='/filetransferone ' element="FileTransferOne" />
                  <Route path='/filetransfermany ' element="FileTransferMany" />
                  {/* Apps */}
                  <Route path='/worksimple' element="Workflow" />
                  <Route path='/worksynch' element="Workflow" />
                </Routes>
            </div>
            </BrowserRouter>
          </div>
        )
      }
  