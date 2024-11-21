import { Outlet } from "react-router-dom";
import './assets/css/layout.css';
import './assets/css/fonts.css';
import Footer from './layouts/Footer';
import MenuTop from './layouts/MenuTop';
import MenuBox from './layouts/MenuBox';


const Layout=()=>{
return (
    <body>
    <header id="header" style={{minHeight:169}}>
    <div class="header_top">
    
        <div class="container_main">
          <MenuTop/>
        </div>
    
    </div>
    
    <div id="main_menu">
    
    </div>
    
    <div class="header">
            <div class="container_main">
            <div class="logo">
                    <a href="/">
                        <img src="https://giadinh.edu.vn/upload/photo/logogdu-02-5690.png" alt="Logo"/>
                    </a>
                </div>
    
                <div id="main_menu">
                    <MenuBox/>
                </div>
    
            </div>
    
    </div>
    
    </header>
    
    <div class="news-home">
        <div class="container_main" style={{minHeight:500}} >

      <Outlet/>

        </div>
    </div>
        
      <Footer/>
    
        </body>
);
}

export default Layout;
