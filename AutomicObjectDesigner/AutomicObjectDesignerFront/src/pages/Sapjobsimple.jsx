import React from 'react';
import { Form } from 'react-bootstrap';
import InputGroup from 'react-bootstrap/InputGroup';
import FloatingLabel from 'react-bootstrap/FloatingLabel';

// need to refactor the style

const SapJobSimple = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;


  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <form>
        <label for="SAP_SID" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400">Select SAP SID</label>
        <select id="SAP_SID" name='SAP_SID' class={cssStyle}>
          <option>Option1</option>
          <option>Option2</option>
          <option>Option3</option>
          <option>Option4</option>
        </select>
        <label for="SAP_Client" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Select SAP Client</label>
        <select id="SAP_Client" name='SAP_Client' class={cssStyle}>
          <option>Option1</option>
          <option>Option2</option>
          <option>Option3</option>
          <option>Option4</option>
        </select>
        <label for="SAP_Report" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Report</label>
        <textarea id="SAP_Report" name='SAP_Report' rows="4" class={cssStyle} placeholder="SAP Report..."></textarea>
        <label for="SAP_Variant" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Variant</label>
        <textarea id="SAP_Variant" name='SAP_Variant' rows="4" class={cssStyle} placeholder="SAP Variant..."></textarea>
        <div class="flex items-center mb-4">
          <input id="routine_job" name='routine_job' type="checkbox" value="" class="w-4 h-4 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
          <label for="routine_job" class="ml-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">Routine Job</label>
        </div>
        <label for="process_name" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300">Process Name</label>
        <input type="text" name='process_name' minLength="7" maxLength="7" id="process_name" class={cssStyle} required />
        <label for="SAP_Job_name" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">SAP Job Name</label>
        <input type="text" name='SAP_Job_name' minLength="7" maxLength="7" id="process_name" class={cssStyle} required />
        <input id="delete_sap_job" name='delete_sap_job' type="checkbox" value="" class="w-4 h-4 my-3 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
        <label for="delete_sap_job" class="ml-2 my-1 text-sm font-medium text-gray-900 dark:text-gray-300">Delete SAP Job</label>
        <p></p>
        <button type="submit" class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Submit</button>
      </form>
    </div>
  )
}

export default SapJobSimple;