package gdu.k16.c221405.demo221405.models;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class Garden 
{
	@Autowired
	public Tree tree;
	
	public String name;
	public String description;
	
	public Garden() 
	{
		super();
		this.name="Khu vuon cua Mr.Gia";
		this.description="Khu vuon cua Mr.Gia";
	}

	public Garden(Tree tree) {
		super();
		this.tree = tree;
		this.name="Khu vuon cua Khoa CNTT";
		this.description="Khu vuon cua Khoa CNTT";
	}
	

}
