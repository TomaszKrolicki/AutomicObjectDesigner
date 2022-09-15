import React from 'react';
import { Form } from 'react-bootstrap';
import InputGroup from 'react-bootstrap/InputGroup';
import FloatingLabel from 'react-bootstrap/FloatingLabel';
import { useLocation, useParams } from 'react-router-dom';
import { useEffect } from 'react';
import axios from 'axios';


export const SapJobBWStep2 = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;

  var SapJobName = "";
  var SapReport = "";
  var SapVariant = "";
  var Kette = "";
  const { state } = useLocation();
  const { id } = state;

  const [data, setData] = React.useState(null);

  // async function fetchObject(){
  //   const SapJobResponse = await fetch('https://localhost:7017/api/SapJobBwChain/'+state);
  //   json = await SapJobResponse.json();
  //   setData(json);}

  useEffect(() => {
    const fetchData = async () => {
      try {
        // console.log("State in fetch data: " + state);
        const result = await fetch(
          'https://localhost:7017/api/SapJobBwChain/' + state,
        );
        const dat = await result.json();
        setData(result);
        if (dat != null) {
          console.log("works");
        } else {
          console.log("doesnt work");
        }
        console.log("Hello kitty");
      } catch (error) {
        console.log("ERROR" + error);
      };}
      fetchData();}, []);

  const [formData, setFormData] = React.useState(
    {
      /// SHOULD FETCH NAME FROM DB(OBJECT NAME BUILD FROM TEMPLATE:
      /// <SAP_SID>.<SAP_CLIENT># <Routine_job># <Process_name>#<SAP_Report>$< SAP_Variant >.JOBS):
      SapJobName: SapJobName,
      SapReport: SapReport,
      SapVariant: SapVariant,
      Kette: Kette,
    }
  )


  function handleChange(event) {
    console.log(event)
    const { name, value, type, checked } = event.target
    setFormData(prevFormData => {
      return {
        ...prevFormData,
        [name]: type === "checkbox" ? checked : value
      }
    })
  }

  async function handleSubmit(event) {
    event.preventDefault()
    try {
      console.log(formData)
      await fetch('https://localhost:7017/api/SapJobBW/2', {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(formData)
      }).then((response) => { console.log(response) }).catch((error) => { console.log(error) })
    } catch (error) {
      console.log(error)
    }
  }

  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <p className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">
        Confirm data:
      </p>
      <form onSubmit={handleSubmit}>
        <label htmlFor="SapJobBwName" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">SAP Job Name</label>
        <input type="text" onChange={handleChange} value={formData.SapJobName} name='SapJobName' minLength="7" maxLength="7" id="SapJobName" className={cssStyle} required />
        <label htmlFor="SapReport" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Report</label>
        <textarea id="SapReport" onChange={handleChange} value={formData.SapReport} name='SapReport' rows="4" className={cssStyle} placeholder="SAP Report..."></textarea>
        <label htmlFor="SapVariant" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Variant</label>
        <textarea id="SapVariant" onChange={handleChange} value={formData.SapVariant} name='SapVariant' rows="4" className={cssStyle} placeholder="SAP Variant..."></textarea>
        <label htmlFor="Kette" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Kette</label>
        <textarea id="Kette" onChange={handleChange} value={formData.Kette} name='Kette' rows="4" className={cssStyle} placeholder="SAP Kette..."></textarea>
        <button type="submit" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Confirm</button>
      </form>
    </div>
  )
}