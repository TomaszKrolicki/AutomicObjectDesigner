import React from 'react';
import { Form } from 'react-bootstrap';
import InputGroup from 'react-bootstrap/InputGroup';
import FloatingLabel from 'react-bootstrap/FloatingLabel';


export const WindowsGeneralStep6 = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;

   const [formData, setFormData] = React.useState(
    {
      VariableKey1: "",
      VariableValue1: "",
      VariableKey2: "",
      VariableValue2: "",
      VariableKey3: "",
      VariableValue3: "",
      VariableKey4: "",
      VariableValue4: "",
      VariableKey5: "",
      VariableValue5: ""
    }
    )

    function handleChange(event) {
      console.log(event)
      const {name, value, type, checked} = event.target
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
        await fetch('https://localhost:7017/api/SapSimple/create', {
          method: 'post',
          headers: {'Content-Type':'application/json'},
          body: JSON.stringify(formData)
      }).then ((response) => {console.log(response)}).catch ((error)=>{console.log(error)})
        } catch (error) {
          console.log(error)
        }
        }

  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <p className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">
      Add form for Variable key and Variable Value(optional)
      </p>
      <div id="container"/>
      <form onSubmit={handleSubmit}>
      {/* <label htmlFor="VariableKey1" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300">Variable key</label>
        <input type="text" onChange={handleChange} value={formData.VariableKey1} name='VariableKey1' maxLength="200" id="VariableKey1" placeholder='Variable Key' className={cssStyle} required />
        <label htmlFor="VariableValue1" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300">Variable value</label>
        <input type="text" onChange={handleChange} value={formData.VariableValue1} name='VariableValue1' maxLength="200" id="VariableValue1" placeholder='VariableValue1' className={cssStyle} required /> */}
        {/* <button type='button' onClick={addField} className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
         focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
          dark:focus:ring-blue-800">Add form</button> */}
        
        <button type="submit" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
         focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
          dark:focus:ring-blue-800">Submit</button>
      </form>
    </div>
  )
}