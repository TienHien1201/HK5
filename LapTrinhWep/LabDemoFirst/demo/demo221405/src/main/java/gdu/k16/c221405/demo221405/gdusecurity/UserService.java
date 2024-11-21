package gdu.k16.c221405.demo221405.gdusecurity;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import jakarta.transaction.Transactional;

@Service
public class UserService implements UserDetailsService {

	@Autowired
    private UserJPA userjpa;

	@Override
    public UserDetails loadUserByUsername(String username) {
		System.out.println("loadUserByUsername Services su dung UserService");
        // Kiểm tra xem user có tồn tại trong database không?
        
		User user = userjpa.findByUsername(username);
        if (user == null) {
            throw new UsernameNotFoundException(username);
        }
        return new CustomUserDetails(user);
      
    }
	
	 // JWTAuthenticationFilter sẽ sử dụng hàm này
    @Transactional
	public UserDetails loadUserById(int id) {
        User user = userjpa.findById(id).orElseThrow(
                () -> new UsernameNotFoundException("User not found with id : " + id)
        );

        return new CustomUserDetails(user);
    }

}
