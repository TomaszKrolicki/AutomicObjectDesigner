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

    var down = document.getElementById("GFG_DOWN");
           
    // Create a break line element
    var br = document.createElement("br");
    function GFG_Fun() {
               
    // Create a form dynamically
    var form = document.createElement("form");
    form.setAttribute("method", "post");
    form.setAttribute("action", "submit.php");
 
    // Create an input element for Full Name
    var FN = document.createElement("input");
    FN.setAttribute("type", "text");
    FN.setAttribute("name", "FullName");
    FN.setAttribute("placeholder", "Full Name");
 
     // Create an input element for date of birth
     var DOB = document.createElement("input");
     DOB.setAttribute("type", "text");
     DOB.setAttribute("name", "dob");
     DOB.setAttribute("placeholder", "DOB");
 
     // Create an input element for emailID
     var EID = document.createElement("input");
     EID.setAttribute("type", "text");
     EID.setAttribute("name", "emailID");
     EID.setAttribute("placeholder", "E-Mail ID");
 
      // Create an input element for password
      var PWD = document.createElement("input");
      PWD.setAttribute("type", "password");
      PWD.setAttribute("name", "password");
      PWD.setAttribute("placeholder", "Password");
 
       // Create an input element for retype-password
       var RPWD = document.createElement("input");
       RPWD.setAttribute("type", "password");
       RPWD.setAttribute("name", "reTypePassword");
       RPWD.setAttribute("placeholder", "ReEnter Password");
 
                // create a submit button
                var s = document.createElement("input");
                s.setAttribute("type", "submit");
                s.setAttribute("value", "Submit");
                 
                // Append the full name input to the form
                form.appendChild(FN);
                 
                // Inserting a line break
                form.appendChild(br.cloneNode());
                 
                // Append the DOB to the form
                form.appendChild(DOB);
                form.appendChild(br.cloneNode());
                 
                // Append the emailID to the form
                form.appendChild(EID);
                form.appendChild(br.cloneNode());
                 
                // Append the Password to the form
                form.appendChild(PWD);
                form.appendChild(br.cloneNode());
                 
                // Append the ReEnterPassword to the form
                form.appendChild(RPWD);
                form.appendChild(br.cloneNode());
                 
                // Append the submit button to the form
                form.appendChild(s);
 
                document.getElementsByTagName("body")[0]
               .appendChild(form);
            }

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

      <p>
          Click on the button to create
          a form dynamically
        </p>
        <button type='button' onClick={GFG_Fun()}>
            click here
        </button>
        <p id="GFG_DOWN"></p>


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