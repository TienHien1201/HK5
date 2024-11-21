package gdu.k16.c221405.demo221405.models;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Primary;

@Configuration
public class Config 
{
	@Bean (name="MyTree")
	@Primary
	public Tree getTree()
	{
		return new Tree("CAY SAU RIENG");
	}

}
