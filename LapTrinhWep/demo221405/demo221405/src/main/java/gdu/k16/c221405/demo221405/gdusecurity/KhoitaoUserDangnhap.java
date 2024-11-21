package gdu.k16.c221405.demo221405.gdusecurity;

import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.ApplicationArguments;
import org.springframework.boot.ApplicationRunner;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Component;

@Component
public class KhoitaoUserDangnhap implements ApplicationRunner {
public static final org.slf4j.Logger logger=LoggerFactory.getLogger(CauhinhSecurityDangnhap.class);
	
	@Autowired
    UserJPA userjpa;
    @Autowired
    PasswordEncoder passwordEncoder;
	
	@Override
	public void run(ApplicationArguments args) throws Exception {
		// TODO Auto-generated method stub
		
		System.out.println("-------------BAT DAU TAO USER--------------------");
		User user = new User();
        user.setUsername("dhgia");
        user.setFirstName("Hoang Gia");
        user.setLastName("Dinh");
        user.isApproved();
        user.setEmail("giadh@giadinh.edu.vn");
        user.setPassword(passwordEncoder.encode("12345678"));
        //password("{bcrypt}$2y$10$GCbwaDs5NpSBFFItT9aGmuYiSNjdH6lHVUPfqctbIbZTprx3Q7Lfi")
        //user.setPassword("{bcrypt}$2y$10$GCbwaDs5NpSBFFItT9aGmuYiSNjdH6lHVUPfqctbIbZTprx3Q7Lfi");
        
        System.out.println("name="+user.getUsername()+",password="+user.getPassword());
        logger.info("insert user:"+userjpa.save(user));
        
        
        User user1 = new User();
        user1.setUsername("admin");
        user1.setFirstName("Admin");
        user1.setLastName("Admin");
        user1.isApproved();
        user1.setEmail("admin@giadinh.edu.vn");
        user1.setPassword(passwordEncoder.encode("12345678"));
        System.out.println("name="+user1.getUsername()+",password="+user1.getPassword());
        logger.info("insert user:"+userjpa.save(user1));
        
        System.out.println("-------------HET TAO USER--------------------");
        System.out.println(user);
		
	}
}
