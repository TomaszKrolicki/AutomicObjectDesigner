import { Route, Routes } from 'react-router-dom';
import { AutomicObjectDesigner } from '../pages/AutomicObjectDesigner';
import { FileTransferMany } from '../pages/FileTransferMany';
import { FileTransferOne } from '../pages/FileTransferOne';
import { SapJobBW } from '../pages/SapJobBW';
import { SapJobMassen } from '../pages/SapJobMassen';
import { SapJobSimple } from '../pages/SapJobSimple';
import { UnixGeneral } from '../pages/UnixGeneral';
import { WindowsGeneral } from '../pages/WindowsGeneral';
import { SapJobSimpleStep2 } from '../pages/SapJobSimpleStep2';

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
                  <Route path='/sapjobsimplestep2' element={<SapJobSimpleStep2 />} />
                  <Route path='/sapjobmassen' element={<SapJobMassen />} />
                  <Route path='/sapjobbw' element={<SapJobBW />} />
                  <Route path='/windowsgeneral' element={<WindowsGeneral />} />
                  <Route path='/unixgeneral' element={<UnixGeneral />} />
                  <Route path='/filetransferone' element={<FileTransferOne />} />
                  <Route path='/filetransfermany' element={<FileTransferMany />} />
                  {/* Apps */}
                  <Route path='/worksimple' element="Workflow" />
                  <Route path='/worksynch' element="Workflow" />
                </Routes>
    </div>
  )
}

export default Routing;