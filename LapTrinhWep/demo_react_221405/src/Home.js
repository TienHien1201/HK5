import { useState } from "react";

const Home=()=>
    {
        var tenlophoc="221405";
        var tenlophoc="221406";
        var array1=["Nguyễn Văn A", "Nguyễn Văn B", "Trần Văn C"];        
        var array2=[{id:1, name:"Nguyễn Văn A", class:"221405"},
            {id:2, name:"Nguyễn Văn B", class:"221406"},
            {id:3, name:"Trần Văn B", class:"221407"}];

        const [array4, setArray4]=useState([
            {
              id:1,
              title:'Việc 1',
              completed:false
          
            },
            {
              id:2,
              title:'Việc 2',
              completed:false
          
            },
            {
              id:3,
              title:'Việc 3',
              completed:true
          
            },      
            {
              id:4,
              title:'Việc 4',
              completed:true      
            },
            {
                id:5,
                title:'Việc 4',
                completed:false      
              }
        ]); 
        var array3=array2.filter(y=>
            {
            return (y.id!==3)&&(y.id!==1);
            }
        );

      const  SuaDulieu=id=>{
                array2.map(xx=>
                 {
                    if (xx.id===id)
                        {
                        xx.name="Ronaldo CR7";
                       }
                    return xx;
                 }

                ); 

            };

    const XoaCongviec=id=>
            {
                const newdscongviec=array4.filter(item=>{
                   return item.id!==id;
                }                   

                );
                setArray4(newdscongviec);
            }

    const SuaCongviec=id=>
        {
            const newdscongviec=array4.map(item=>
                {
                    if (item.id===id)
                        item.title="Messi M10";
                    return item;
                }
            );
            setArray4(newdscongviec);
        }
      
    const ThemCongviec=()=>
        {
            var newitem={id:6,title:'Việc 6',completed:false};
            setArray4([...array4,newitem]);
        }

    const CheckVieclamduoc=id=>
        {
            const newdscongviec=array4.map(item=>
                {
                    if (item.id===id)
                        item.completed=!item.completed;
                    return item;
                }
            );
            setArray4(newdscongviec); 

        }


        return (
            <div>
                <h1>Xin chào các bạn {tenlophoc} thân mến!</h1>
                <div>Danh sách họ tên </div>
                {
                    array1.map(x=>{ 
                        return(                      
                            <p>
                            <span>{x}</span>
                            <input type="textbox" value={x}/>
                            </p>
                        )                    
                    }
                    )
                }

                <div>Danh sách sinh viên </div>
                {
                    array2.map(x=>{ 
                        return(                      
                            <p>
                            <span>{x.id}</span>&nbsp;&nbsp;
                            <input type="textbox" value={x.name}/>&nbsp;&nbsp;
                            <span>Lớp: {x.class}</span>
                            <input type="button" onClick={SuaDulieu.bind(this,x.id)} value="Sửa dữ liệu"/>
                            </p>
                        )                    
                    }
                    )
                }

                <div>Danh sách sinh viên3 </div>
                {
                    array3.map(x=>{ 
                        return(                      
                            <p>
                            <span>{x.id}</span>&nbsp;&nbsp;
                            <input type="textbox" value={x.name}/>&nbsp;&nbsp;
                            <span>Lớp: {x.class}</span>
                            </p>
                        )                    
                    }
                    )
                }
            <div style={{color:'green', paddingTop:50}}>Việc cần làm</div>
                {
                    array4.map(item=>{
                        return (
                            <p>
                            <span>{item.id}</span>&nbsp;&nbsp;
                            <input type="textbox" value={item.title}/>&nbsp;&nbsp;
                            <input type="checkbox" checked={item.completed}/>&nbsp;&nbsp;                            
                            </p>  
                        );
                    }

                    )
                }

                <div style={{color:'red', paddingTop:50}}>Việc cần làm</div>
                {
                    array4.map(item=>{
                        return (
                            <p>
                            <span>{item.id}</span>&nbsp;&nbsp;
                            <input type="textbox" value={item.title}/>&nbsp;&nbsp;
                            <input type="checkbox" checked={item.completed} onClick={CheckVieclamduoc.bind(this,item.id)} />&nbsp;&nbsp;
                            <input type="button" value="Xóa" onClick={XoaCongviec.bind(this,item.id)}/>

                            <input type="button" value="Sửa" onClick={SuaCongviec.bind(this,item.id)}/>
                            </p>  
                        );
                    }                  

                    )
                }

                <input type="button" value="Thêm công việc" onClick={ThemCongviec.bind(this)}/>
               
               <div style={{height:100}}></div>
            </div>
            
        );
    }


    
export default Home;