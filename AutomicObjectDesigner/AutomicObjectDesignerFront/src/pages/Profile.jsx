import React from 'react'
import { Header } from '../components/Header';
import { useStateContext } from '../contexts/ContextProvider';

export const Profile = () => {
  const buttonStyle="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"
  return (
    <div className="mt-24">
      <button type='button' className={buttonStyle}>Change email</button>
      <button type='button' className={buttonStyle}>Change password</button>
      <button type='button' className={buttonStyle}>View files</button>
      <button type='button' className="text-white bg-red-700 hover:bg-red-800 focus:ring-4 focus:outline-none focus:ring-red-300 
      font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-red-600 dark:hover:bg-red-700 dark:focus:ring-red-800">Delete account</button>
    </div>
  )
}