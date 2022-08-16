import React, { Component } from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom'
//import './bootstrap/sb-admin-2.min.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import Login from './components/login.component'
import SignUp from './components/register.component'

// export default function App() {
//     return (
//         <Router>
//           <div className="container-xl">
//             <nav className='text-center'>
//                 <Link className="h1 text-black-50 text-center nav-item" to={'/sign-in'}>
//                   AutomicObjectDesigner
//                 </Link>
//                 <div className="collapse navbar-collapse" id="navbarTogglerDemo02">
//                   <ul className="navbar-nav ml-auto">
//                     <li className="nav-item">
//                       <Link className="nav-link" to={'/sign-in'}>
//                         Login
//                       </Link>
//                     </li>
//                     <li className="nav-item">
//                       <Link className="nav-link" to={'/sign-up'}>
//                         Sign up
//                       </Link>
//                     </li>
//                   </ul>
//               </div>
//             </nav>
//             <div className="auth-wrapper">
//               <div className="auth-inner">
//                 <Routes>
//                   <Route exact path="/" element={<Login />} />
//                             <Route path="/sign-in" element={<Login />} />
//                             <Route path="/register" element={<SignUp />} />
//                 </Routes>
//               </div>
//             </div>
//           </div>
//         </Router>
//       )
//     }


    export default function App() {
      return (
          <div>
            
          </div>
        )
      }
  

// export default class App extends Component {
//     static displayName = App.name;

//     constructor(props) {
//         super(props);
//         this.state = { forecasts: [], loading: true };
//     }

//     componentDidMount() {
//         this.populateWeatherData();
//     }

//     static renderForecastsTable(forecasts) {
//         return (
//             <table className='table table-striped' aria-labelledby="tabelLabel">
//                 <thead>
//                     <tr>
//                         <th>Date</th>
//                         <th>Temp. (C)</th>
//                         <th>Temp. (F)</th>
//                         <th>Summary</th>
//                     </tr>
//                 </thead>
//                 <tbody>
//                     {forecasts.map(forecast =>
//                         <tr key={forecast.date}>
//                             <td>{forecast.date}</td>
//                             <td>{forecast.temperatureC}</td>
//                             <td>{forecast.temperatureF}</td>
//                             <td>{forecast.summary}</td>
//                         </tr>
//                     )}
//                 </tbody>
//             </table>
//         );
//     }

//     render() {
//         let contents = this.state.loading
//             ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
//             : App.renderForecastsTable(this.state.forecasts);

//         return (
//             <div>
//                 <h1 id="tabelLabel" >Weather forecast</h1>
//                 <p>This component demonstrates fetching data from the server.</p>
//                 {contents}
//             </div>
//         );
//     }

//     async populateWeatherData() {
//         const response = await fetch('weatherforecast');
//         const data = await response.json();
//         this.setState({ forecasts: data, loading: false });
//     }
// }
