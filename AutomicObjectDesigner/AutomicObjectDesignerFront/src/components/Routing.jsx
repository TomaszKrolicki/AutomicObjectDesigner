import { Route, Routes } from 'react-router-dom';
import { AutomicObjectDesigner } from '../pages/AutomicObjectDesigner';
import { FileTransferMany } from '../pages/FileTransferMany';
import { FileTransferOne } from '../pages/FileTransferOne';

import { SapJobBWStep1 } from '../pages/SapJobBWStep1';
import { SapJobBWStep2 } from '../pages/SapJobBWStep2';
import { SapJobBWStep3 } from '../pages/SapJobBWStep3';
import { SapJobBWStep4 } from '../pages/SapJobBWStep4';

import { SapJobMassen } from '../pages/SapJobMassen';

import { UnixGeneralStep1 } from '../pages/UnixGeneralStep1';
import { UnixGeneralStep2 } from '../pages/UnixGeneralStep2';
import { UnixGeneralStep3 } from '../pages/UnixGeneralStep3';
import { UnixGeneralStep4 } from '../pages/UnixGeneralStep4';

import { WindowsGeneralStep1 } from '../pages/WindowsGeneralStep1';

import { SapJobSimpleStep1 } from '../pages/SapJobSimpleStep1';
import { SapJobSimpleStep2 } from '../pages/SapJobSimpleStep2';
import { SapJobSimpleStep3 } from '../pages/SapJobSimpleStep3';
import { SapJobSimpleStep4 } from '../pages/SapJobSimpleStep4';

import { NotFound } from '../pages/NotFound';

import React from 'react';

const Routing = () => {
  return (
    <div>
      <Routes>
        {/* Dashboard */}
        <Route path='/' element={<AutomicObjectDesigner />} />
        <Route path='/automicobjectdesigner' element={<AutomicObjectDesigner />} />
        {/* Pages */}
        <Route path='/sapjobsimple/1' element={<SapJobSimpleStep1 />} />
        <Route path='/sapjobsimple/2/' element={<SapJobSimpleStep2 />} />
        <Route path='/sapjobsimple/3/' element={<SapJobSimpleStep3 />} />
        <Route path='/sapjobsimple/4/' element={<SapJobSimpleStep4 />} />

        <Route path='/SapJobBW/1' element={<SapJobBWStep1 />} />
        <Route path='/SapJobBW/2' element={<SapJobBWStep2 />} />
        <Route path='/SapJobBW/3' element={<SapJobBWStep3 />} />
        <Route path='/SapJobBW/4' element={<SapJobBWStep4 />} />
      {/* Alternative solution: */}
      {/* <Route path='/SapJobBW/2/:id' element={<SapJobBWStep2 />} />
        <Route path='/SapJobBW/3/:id' element={<SapJobBWStep3 />} />
        <Route path='/SapJobBW/4/:id' element={<SapJobBWStep4 />} /> */}


        <Route path='/sapjobmassen' element={<SapJobMassen />} />

        <Route path='/windowsGeneral/1' element={<WindowsGeneralStep1 />} />

        <Route path='/unixGeneral/1' element={<UnixGeneralStep1 />} />
        <Route path='/unixGeneral/2' element={<UnixGeneralStep2 />} />
        <Route path='/unixGeneral/3' element={<UnixGeneralStep3 />} />
        <Route path='/unixGeneral/4' element={<UnixGeneralStep4 />} />

        <Route path='/filetransferone' element={<FileTransferOne />} />
        <Route path='/filetransfermany' element={<FileTransferMany />} />
        {/* Apps */}
        <Route path='/worksimple' element="Workflow" />
        <Route path='/worksynch' element="Workflow" />
        {/* Function */}
        <Route path='*' element={<NotFound />} />
      </Routes>
    </div>
  )
}

export default Routing;