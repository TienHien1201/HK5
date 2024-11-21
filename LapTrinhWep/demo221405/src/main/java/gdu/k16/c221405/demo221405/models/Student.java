package gdu.k16.c221405.demo221405.models;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;



@Entity
public class Student 
{
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	private String studentnumber;
	private String name;
	private String classnumber;
	private String email;
	private String address;
	
	public Student(int id, String studentnumber, String name, String classnumber, String email, String address) 
	{
		super();
		this.id = id;
		this.studentnumber = studentnumber;
		this.name = name;
		this.classnumber = classnumber;
		this.email = email;
		this.address = address;
	}
	
	public Student(String studentnumber, String name, String classnumber, String email, String address) 
	{
		super();
		this.id = id;
		this.studentnumber = studentnumber;
		this.name = name;
		this.classnumber = classnumber;
		this.email = email;
		this.address = address;
	}
	public Student() {
		super();
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getStudentnumber() {
		return studentnumber;
	}
	public void setStudentnumber(String studentnumber) {
		this.studentnumber = studentnumber;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getClassnumber() {
		return classnumber;
	}
	public void setClassnumber(String classnumber) {
		this.classnumber = classnumber;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	
	
	
	
	

}
