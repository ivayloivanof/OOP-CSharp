package com.homework.pccatalog;

public class Component {

	private String name;
	private long price;
	private String details;
	
	public Component(String name, long price) throws Exception {
		setName(name);
		setPrice(price);
	}
	
	public Component(String name, long price, String details) throws Exception {
		this(name, price);
		setDetails(details);
	}
	public String getName() {
		return name;
	}
	public void setName(String name) throws Exception {
		if (name == null || name.trim().length() == 0) {
			throw new Exception();
		}
		this.name = name;
	}
	public long getPrice() {
		return price;
	}
	public void setPrice(long price) throws Exception {
		if (price <= 0) {
			throw new Exception();
		}
		
		this.price = price;
	}
	public String getDetails() {
		return details;
	}
	public void setDetails(String details) throws Exception {
		if (details == null || details.trim().length() == 0) {
			throw new Exception();
		}
		
		this.details = details;
	}

	@Override
	public String toString() {
		return "Component [name=" + name + ", price=" + price + ", details="
				+ details + "]";
	}
	
}
