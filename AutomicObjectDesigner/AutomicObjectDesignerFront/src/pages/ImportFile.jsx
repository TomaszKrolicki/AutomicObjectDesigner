import React from 'react'

export const ImportFile = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;

   const [formData, setFormData] = React.useState(
    {
      Job: "SapSimple"
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

  return (
    <div className='md:px-4 py-2.5 container w-800'>
      
        <label htmlFor="Job" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400">Select Job for import</label>
        <select onChange={handleChange} value={formData.Job} name='Job' className={cssStyle}>
          <option value={"Option1"}>SapSimple</option>
          <option value={"Option2"}>SapJobBw</option>
          <option value={"Option3"}>UnixGeneral</option>
          <option value={"Option4"}>WindowsGeneral</option>
        </select>
        
    </div>
  )
}