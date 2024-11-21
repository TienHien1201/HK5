package gdu.k16.c221405.demo221405.models;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;



public interface StudentJPA extends JpaRepository<Student, Integer> 
{
	@Query(value ="select s from Student s where s.classnumber=:classnumber")
	List<Student> fillAllByClassName2(@Param("classnumber") String classnumber);
	
	@Query(nativeQuery = true, value="select * from STUDENT s where s.classnumber=:classnumber")
	List<Student> fillAllByClassName3(@Param("classnumber") String classnumber);

}
