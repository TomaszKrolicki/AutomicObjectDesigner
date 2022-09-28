import React from 'react';
import { useLocation, BrowserRouter as Router, } from 'react-router-dom';
import { useEffect } from 'react';


export const ExportSite = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;

  const { state } = useLocation();
  console.log(state.type);
  //  const { state } = 1;
  //console.log("Export site - Id: " + state);

  const url = 'https://localhost:7017/api/' + state.type + state.num;
  console.log("Fetching url: " + url)

  useEffect(() => {
    const fetchData = async () => {
      try {
        const result = await fetch(url);
        const dat = await result.json();
        console.log(dat);
        if (dat != null) {
          console.log(dat);
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

  const [post, setPost] = React.useState(null);

  // let Navigate = useNavigate();
  async function handleClick() {
    try {
      const SapJobResponse = await fetch('https://localhost:7017/api/SapJobBwChain/DownloadExcelFile/' + id, {})
    } catch (error) {
      console.log("ERROR" + error)
    }
  }



  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <p className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">
        This is the object with your paramaters:
      </p>
      <div className='mp-2 font-blackcolumns-2 dark:text-gray-300' id='object'>
      </div>
      <div className='my-10'>
      <button onClick={handleClick} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export XML</button>
      <button onClick={handleClick} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg mx-4 text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export JSON</button>
      <button onClick={handleClick} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export CSV</button>
      </div>
    </div>
  )
}