import React from 'react';
import { useLocation } from 'react-router-dom';
import { useEffect } from 'react';



export const ExportSite = () => {


  const { state } = useLocation();
  console.log(state.type);

  const url = 'https://localhost:7017/api/' + state.type;
  const getUrl = url + 'ExportSite/' + state.num;

  useEffect(() => {
    const fetchData = async () => {
      try {
        const result = await fetch(getUrl, {
          headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
        });
        const dat = await result.json();
        if (dat != null) {
          document.getElementById("object").innerText = JSON.stringify(dat);
        } else {
          console.warn("Data couldn't be fetched");
        }
      } catch (error) {
        console.error(error)
      }
    }
    fetchData();
  }, []);



  async function handleClickCsv() {
    try {
      const SapJobResponse = await fetch(url + 'CsvFile/' + state.num, {
        headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
      });
    } catch (error) {
      console.log("ERROR" + error)
    }
    const adres = url+"CsvFile/"+ state.num;
    console.log(adres)
    window.open(adres, '_blank', 'noopener,noreferrer');
  }

  async function handleClickJson() {
    try {
      const SapJobResponse = await fetch(url + 'JsonFile/' + state.num, {
        headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
      })
    } catch (error) {
      console.log("ERROR" + error)
    }
    window.open(url+"JsonFile/"+ state.num, '_blank', 'noopener,noreferrer');

  }





  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <p className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">
        This is the object with your paramaters:
      </p>
      <div className='mp-2 font-blackcolumns-2 dark:text-gray-300' id='object'>
      </div>
      <div className='my-10'>
      <button onClick={handleClickJson} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg mx-4 text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export JSON</button>
      <button onClick={handleClickCsv} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export CSV</button>
      </div>
    </div>
  )
}