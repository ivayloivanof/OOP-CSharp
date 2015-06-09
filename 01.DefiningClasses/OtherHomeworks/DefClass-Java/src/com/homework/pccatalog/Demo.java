package com.homework.pccatalog;

import java.util.ArrayList;
import java.util.List;

public class Demo {

	public static void main(String[] args) throws Exception {
		List<Component> comps1 = new ArrayList<Component>();
		List<Component> comps2 = new ArrayList<Component>();
		List<Component> comps3 = new ArrayList<Component>();
		
		comps1.add(new Component("video card", 2601));
		comps1.add(new Component("hard drive", 2602));
		comps1.add(new Component("ram", 1024, "newest 1024 mb ram yeaaah"));
		
		comps2.add(new Component("video card", 2101));
		comps2.add(new Component("hard drive", 1642));
		comps2.add(new Component("ram", 754));
		comps2.add(new Component("ram", 2454));
		
		comps3.add(new Component("video card", 2611));
		
		List<Computer> computers = new ArrayList<Computer>();
		computers.add(new Computer("megadeath", comps1));
		computers.add(new Computer("ultratron", comps2));
		computers.add(new Computer("motorhead", comps3));
		
//		computers.sort();
		
	}
	
}
