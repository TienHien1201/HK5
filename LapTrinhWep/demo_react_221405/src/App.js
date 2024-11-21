import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Layout from './Layout';
import Home from './Home';
import Home1 from './Home1';

const App=()=>{

  const class_name="221405";
  

  return (

    <BrowserRouter>
    <Routes>
        <Route path="/" element={<Layout />}>
        <Route index path="/trang1" element={<Home />} />    
        <Route index path="/" element={<Home1 />} />    
       
      </Route>
    </Routes>
  </BrowserRouter>
  );
}

export default App;
