import { useEffect, useState } from "react";
import axios from "axios";
import EditItem from "./EditItem";

const Home1=()=>
{
    const [dscongviec, Setdscongviec]=useState([]);/*Mới đầu cái mảng trong useState là rỗng*/
    const [congviec, SetCongviec]=useState({userId:0, id:0, title:'', completed:false});

    const LaydulieuTuBackend=async ()=>
    {
        const res= await axios.get("https://jsonplaceholder.typicode.com/todos?_limit=6");
        Setdscongviec(res.data);

    }


    const XoaDulieu=async id=>
    {
         /*Xóa trong backend*/

         const res =await axios.delete("https://jsonplaceholder.typicode.com/todos/{id}");
         console.log("Trạng thái xóa trong backend:"+res.status);

        /*Xóa trong mảng*/
        const newdscongviec=dscongviec.filter(x=>x.id!==id);
        Setdscongviec(newdscongviec);       

    }

    const SuaDulieu=id=>
    {
        const newcongviec=dscongviec.find(item=>item.id===id);
        SetCongviec(newcongviec);
    }

    const CallBack=async objcongviec=>
    {
        SetCongviec(objcongviec);
        /*Lấy objcongviec được truyền về cập nhật lại cho dscongviec */        

        const newcongviec=dscongviec.map(item=>
        {
            if (item.id==objcongviec.id)
            {
                item.title=objcongviec.title;
                item.completed=objcongviec.completed;
            }
            return item;
        });
        SetCongviec(newcongviec);
        /*Cập nhật vào backend*/
        const res= await axios.put('https://jsonplaceholder.typicode.com/todos/'+congviec.id,
            {userId:congviec.userId, id:congviec.id, title:congviec.title,completed:congviec.completed});
        console.log("Kiểm tra trạng thái cập nhật trong backend:"+res.status);

    }


    useEffect(()=>
        {
		LaydulieuTuBackend();
        }
    ,[]);

    const itemStyle={
        padding:'10px',
        color:'blue'
    }

    
    return (
        <div>
             <div style={{color:'green', paddingTop:50, paddingBottom:30}}>Việc cần làm</div>
                {
                    dscongviec.map(item=>{
                        return (
                            <p>
                            <span>{item.id}</span>&nbsp;&nbsp;
                            <input type="textbox" value={item.title}/>&nbsp;&nbsp;
                            <input type="checkbox" checked={item.completed}/>&nbsp;&nbsp;                            
                            <div>&nbsp;</div>
                            </p>  
                        );
                    }

                    )
                }

        <EditItem congviecProps={congviec} callbackFunc={CallBack} />


            <div style={{color:'red', paddingTop:50}}>Việc cần làm</div>
                {
                    dscongviec.map(item=>{
                        return (
                            <p style={itemStyle}>
                            <span>{item.id}</span>&nbsp;&nbsp;
                            <input type="textbox" value={item.title}/>&nbsp;&nbsp;
                            <input type="checkbox" checked={item.completed}  />&nbsp;&nbsp;
                            <input type="button" value="Xóa" onClick={XoaDulieu.bind(this, item.id)}    />

                            <input type="button" value="Sửa" onClick={SuaDulieu.bind(this,item.id)}     />
                            </p>  
                        );
                    }                  

                    )
                }
        </div>
    );

}
export default Home1;