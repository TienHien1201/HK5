package gdu.k16.c221405.demo221405.models;

import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Component;

@Component
public class Tree 
{
	public String name;
	public String description;
	public String size;
	
	public Tree() {
		
		super();
		this.name="Day la cay oi";
		this.description="Mo ta ve cay oi";
	}

	public Tree(String name) {
		super();
		this.name = name;
		this.description="Mo ta ve "+this.name;
	}

	
	

}
