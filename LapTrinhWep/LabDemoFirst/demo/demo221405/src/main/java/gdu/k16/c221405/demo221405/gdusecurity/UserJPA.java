package gdu.k16.c221405.demo221405.gdusecurity;

import org.springframework.data.jpa.repository.JpaRepository;


public interface UserJPA extends JpaRepository<User, Integer> {
	User findByUsername(String username);
}
