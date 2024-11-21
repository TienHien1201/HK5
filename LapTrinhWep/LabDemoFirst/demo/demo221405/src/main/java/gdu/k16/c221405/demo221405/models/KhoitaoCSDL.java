package gdu.k16.c221405.demo221405.models;

import java.util.Random;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.ApplicationArguments;
import org.springframework.boot.ApplicationRunner;
import org.springframework.context.annotation.Configuration;



//@Configuration
public class KhoitaoCSDL implements ApplicationRunner 
{
	
	String[] ho= {"Nguyễn", "Lê", "Trần", "Hồ", "Lều", "Đinh", "Mạc", "Văn", "Ninh", "Dương"};
    String[] ten= {"Anh", "Ngọc An", "Bình", "Quỳnh", "Hoài Ân", "Văn Toản", "Thắng", "Thịnh", "Trường", "Ngân"};
    String[] diachi={"371 Nguyễn Kiệm, P3, Gò Vấp","Lý Thường Kiêt, P.7, Quận 10", "Ninh Thuận", "Bình Thuận","Bình Chánh", "Quận 8","Quận 1, TP. Hồ Chí Minh", "Quận 7, TP.Hồ Chí Minh", "Đức Hòa, Long An","Gò Công Đông, Tiền Giang"};
    
    
    private StudentJPA jpa;

    @Autowired
    public KhoitaoCSDL(StudentJPA jpa) {
        this.jpa = jpa;
    }
    
    private static int random1()
    {
    	Random rand = new Random();   	

    	int randomNum = rand.nextInt((9) + 1);
    	return randomNum;
    }
    

	@Override
	public void run(ApplicationArguments args) throws Exception {
		// TODO Auto-generated method stub
		
		for (int i=0; i<1000; i++)
		{
		jpa.save(new Student(ho[random1()]+" "+ten[random1()],"221402"+(i+1),"221402","abc@gdu.edu.vn", diachi[random1()] ));
		}
		
	}

}
