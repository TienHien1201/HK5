package gdu.k16.c221405.demo221405.controller;

import java.util.*;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import gdu.k16.c221405.demo221405.models.Student;
import gdu.k16.c221405.demo221405.models.StudentJPA;

@RestController
public class StudentController 
{
	@Autowired
	StudentJPA jpa;
	
	@GetMapping("/liststudents")
	public List<Student> liststudents()
	{

		List<Student>lst=jpa.fillAllByClassName2("221405");
		return lst;
		
	}
	
	@PostMapping("/insertStudent")
	public String insertStudent(@RequestBody Student newstudent)
	{		
		jpa.save(newstudent);		
		return "Thêm sinh viên thành công!";	
		
	}
	
	@PutMapping("/updateStudent")
	public String updateStudent(@RequestBody Student student)
	{	
		jpa.save(student);		
		return "Sửa sinh viên thành công!";		
		
	}
	@DeleteMapping("/deleteStudent/{id}")
	public String deleteStudent(@PathVariable Integer id)
	{		
		jpa.deleteById(id);		
		return "Xóa thành công!";
			
	}

}
