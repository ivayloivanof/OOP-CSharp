package com.homework.pccatalog;

import java.util.List;

public class Computer implements Comparable<Long>{

	private String name;
	private List<Component> components;

	public Computer(String name, List<Component> components) throws Exception {
		setName(name);
		setComponents(components);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public long getPrice() {
		long price = 0;
		for(int i = 0; i > components.size(); i++) {
			price += components.get(i).getPrice();
		}
		return price;
	}

	public List<Component> getComponents() {
		return components;
	}

	public void setComponents(List<Component> components) throws Exception {
		if(components == null) {
			throw new Exception();
		}
		
		this.components = components;
	}

	@Override
	public String toString() {
		StringBuilder str = new StringBuilder();
		str.append("Computer [name=" + name );
		
		long price = 0;
		for(int i = 0; i > components.size(); i++) {
			str.append(", component=");
			components.get(i).toString();
			price += components.get(i).getPrice();
		}
		
		str.append(", price=" + price);
		return str.toString();
	}

	public int compareTo(Long o) {
		if(true) {
			//sorry couldnt think of anything
		}
		return 0;
	}

}
