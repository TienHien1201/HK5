import PropTypes from 'prop-types';
import { useState, useEffect } from 'react';

const EditItem=props=>
{
    const [congviec, SetCongviec]=useState({userId:0, id:0, title:'', completed:false});
    const CallBackfromParent = props.callbackFunc;

    const divstyle={
        border:'2px solid #0a7a3f',
        padding:'10px',
        backgroundColor: "#cfac54",
        width:'500px'
        
    }

    const titlechange=e=>
        {
            let title=e.target.value;           
            const newcongviec={...congviec, title:title};
            SetCongviec(newcongviec);
            

        }

    const completedchange=e=>
        {
            const previousValue = e.target.previousValue;
            const newValue = e.target.value;
            const ischeck=e.target.checked;
            console.log("newValue:"+newValue+",previousValue:"+previousValue+",ischeck:"+ischeck);
            const newcongviec={...congviec, completed:ischeck};
            SetCongviec(newcongviec);
        }

    const Submission=event=>
            {            
                event.preventDefault();
                CallBackfromParent(congviec);
    
            }

    useEffect(()=>
        {
            SetCongviec(props.congviecProps);
        }
    ,[props.congviecProps]);

    return (
        <form onSubmit={Submission}  >
        <div style={divstyle}>
        <h3>Sửa dữ liệu</h3>
        <span>{congviec.id}</span>&nbsp;&nbsp;
        <input type="textbox" style={{width:300}} value={congviec.title} onChange={titlechange}  />&nbsp;&nbsp;
        <input type="checkbox" checked={congviec.completed} onChange={completedchange}    />&nbsp;&nbsp; 
        <div style={{padding:10,paddingLeft:100}}>
            <input style={{textAalign: 'center', width:100, height:25,border: 'none', color: 'white', display: 'inline-block', fontSize:16, backgroundColor:'#008CBA'}} type='submit' value="Cập nhật"/>
        </div>

        </div>
        </form>
    );
}

EditItem.prototype={
    congviecProps:PropTypes.object.isRequired,
    callbackFunc:PropTypes.func.isRequired    
    }

export default EditItem;