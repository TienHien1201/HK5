package gdu.k16.c221405.demo221405;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ConfigurableApplicationContext;

import gdu.k16.c221405.demo221405.models.Garden;
import gdu.k16.c221405.demo221405.models.Tree;

@SpringBootApplication
public class Demo221405Application {

	public static void main(String[] args) {
		ConfigurableApplicationContext ctx=SpringApplication.run(Demo221405Application.class, args);
		System.out.println("Bat dau test");
		
		Garden garden=ctx.getBean(Garden.class);
		
		System.out.println("Garden.name:"+garden.name);
		System.out.println("Kiem tra garden.tree:"+garden.tree);
		System.out.println("Kiem tra garden.tree:"+garden.tree.name);
		
	}

}
