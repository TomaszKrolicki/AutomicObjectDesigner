import React from 'react';
import { Form } from 'react-bootstrap';
import InputGroup from 'react-bootstrap/InputGroup';
import FloatingLabel from 'react-bootstrap/FloatingLabel';


export const SapJobSimple = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;

   const [formData, setFormData] = React.useState(
    {
        SAP_SID: "", 
        SAP_Client: "", 
        SAP_Report: "", 
        SAP_Variant: "", 
        routine_job: false,
        process_name: "",
        SAP_Job_name: "",
        delete_sap_job: false,
        folder: null,
        active: null,
        maxParallelTasks: null,
        process: null,
        preProcess: null,
        postProcess: null,
        queue: null,
        agent: null
    }
    )

    function handleChange(event) {
      //console.log(event)
      const {name, value, type, checked} = event.target
      // console.log(formData.SAP_SID)
      // console.log(formData.SAP_Client)
      // console.log(formData.SAP_Report)
      // console.log(formData.SAP_Variant)
      // console.log(formData.routine_job)
      // console.log(formData.process_name)
      // console.log(formData.SAP_Job_name)
      // console.log(formData.delete_sap_job)
      setFormData(prevFormData => {
          return {
              ...prevFormData,
              [name]: type === "checkbox" ? checked : value
          }
      })
    }
    function handleSubmit(event) {
      event.preventDefault()
      try {
        console.log(formData)
      fetch('https://localhost:7017/api/SapSimple', {
        method: 'post',
        headers: {'Content-Type':'application/json'},
        body: formData
    })
      } catch (error) {
        console.log(error)
      }
      }

  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <form onSubmit={handleSubmit}>
        <label htmlFor="SAP_SID" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400">Select SAP SID</label>
        <select onChange={handleChange} value={formData.SAP_SID} id="SAP_SID" name='SAP_SID' className={cssStyle}>
          <option>Option1</option>
          <option>Option2</option>
          <option>Option3</option>
          <option>Option4</option>
        </select>
        <label htmlFor="SAP_Client" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Select SAP Client</label>
        <select onChange={handleChange} value={formData.SAP_Client} id="SAP_Client" name='SAP_Client' className={cssStyle}>
          <option>Option1</option>
          <option>Option2</option>
          <option>Option3</option>
          <option>Option4</option>
        </select>
        <label htmlFor="SAP_Report" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Report</label>
        <textarea id="SAP_Report" onChange={handleChange} value={formData.SAP_Report}  name='SAP_Report' rows="4" className={cssStyle} placeholder="SAP Report..."></textarea>
        <label htmlFor="SAP_Variant" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Variant</label>
        <textarea id="SAP_Variant" onChange={handleChange} value={formData.SAP_Variant} name='SAP_Variant' rows="4" className={cssStyle} placeholder="SAP Variant..."></textarea>
        <div className="flex items-center mb-4">
          <input id="routine_job" onChange={handleChange} value={formData.routine_job} name='routine_job' type="checkbox" value="" className="w-4 h-4 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
          <label htmlFor="routine_job" className="ml-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">Routine Job</label>
        </div>
        <label htmlFor="process_name" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300">Process Name</label>
        <input type="text" onChange={handleChange} value={formData.process_name}  name='process_name' minLength="7" maxLength="7" id="process_name" className={cssStyle} required />
        <label htmlFor="SAP_Job_name" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">SAP Job Name</label>
        <input type="text" onChange={handleChange} value={formData.SAP_Job_name}  name='SAP_Job_name' minLength="7" maxLength="7" id="process_name" className={cssStyle} required />
        <input id="delete_sap_job" name='delete_sap_job' onChange={handleChange} value={formData.delete_sap_job} type="checkbox" value="" className="w-4 h-4 my-3 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
        <label htmlFor="delete_sap_job" className="ml-2 my-1 text-sm font-medium text-gray-900 dark:text-gray-300">Delete SAP Job</label>
        <p></p>
        <button type="submit" className="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Submit</button>
      </form>
    </div>
  )
}