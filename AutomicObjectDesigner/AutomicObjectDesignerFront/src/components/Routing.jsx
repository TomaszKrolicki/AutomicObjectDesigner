import { Route, Routes } from 'react-router-dom';
import { AutomicObjectDesigner, FileTransferMany, FileTransferOne,
  SapJobBW, SapJobMassen, SapJobSimple, UnixGeneral, WindowsGeneral } from '../pages';

import React from 'react';

const Routing = () => {
  return (
    <div>
        <Routes>
                  {/* Dashboard */}
                  <Route path='/' element={<AutomicObjectDesigner />} />
                  <Route path='/automicobjectdesigner' element={<AutomicObjectDesigner />} />
                  {/* Pages */}
                  <Route path='/sapjobsimple' element={<SapJobSimple />} />
                  <Route path='/sapjobmassen' element={<SapJobMassen />} />
                  <Route path='/sapjobbw ' element={<SapJobBW />} />
                  <Route path='/windowsgeneral' element={<WindowsGeneral />} />
                  <Route path='/unixgeneral' element={<UnixGeneral />} />
                  <Route path='/filetransferone ' element={<FileTransferOne />} />
                  <Route path='/filetransfermany ' element={<FileTransferMany />} />
                  {/* Apps */}
                  <Route path='/worksimple' element="Workflow" />
                  <Route path='/worksynch' element="Workflow" />
                </Routes>
    </div>
  )
}

export default Routing;