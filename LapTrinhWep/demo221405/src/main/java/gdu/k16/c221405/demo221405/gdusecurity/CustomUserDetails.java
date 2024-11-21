package gdu.k16.c221405.demo221405.gdusecurity;

import java.util.Collection;
import java.util.Collections;

import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;


public class CustomUserDetails implements UserDetails {

	private static final int serialVersionUID = 1;
	CustomUserDetailsData data = new CustomUserDetailsData();

	@Override
	public Collection<? extends GrantedAuthority> getAuthorities() {
		return Collections.singleton(new SimpleGrantedAuthority("USER"));
	}
	
	
//	private Collection<? extends GrantedAuthority> getAuthorities(
//			  Collection<Role> roles) {
//			    List<GrantedAuthority> authorities
//			      = new ArrayList<>();
//			    for (Role role: roles) {
//			        authorities.add(new SimpleGrantedAuthority(role.getRoleName()));
//			        role .getPrivileges().stream()
//			         .map(p -> new SimpleGrantedAuthority(p.getName()))
//			         .forEach(authorities::add);
//			    }
//			    
//			    return authorities;
//			}
	
	
	
	public CustomUserDetails(CustomUserDetailsData data) {
		super();
		this.data = data;
	}
	

    public CustomUserDetails(User user) {
		super();
		this.data.user = user;
	}

	@Override
    public String getPassword() {
    	User user =data.user;
    	
    	
        return user.getPassword();
    }
	
	public User getUser() {
        return data.user;
    }
	

    @Override
    public String getUsername() {
        return data.user.getUsername();
    }

    @Override
    public boolean isAccountNonExpired() {
        return true;
    }

    @Override
    public boolean isAccountNonLocked() {
        return true;
    }

    @Override
    public boolean isCredentialsNonExpired() {
        return true;
    }

    @Override
    public boolean isEnabled() {
        return true;
    }

}
