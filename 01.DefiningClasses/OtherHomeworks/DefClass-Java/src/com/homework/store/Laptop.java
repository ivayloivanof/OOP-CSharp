package com.homework.store;

public class Laptop {

	private String model;
	private String manufacturer;
	private String processor;
	private String ram;
	private String graphicsCard;
	private String hdd;
	private String screen;
	private Battery battery;
	private float batteryLifeHours;
	private double price;

	public Laptop(String model, double price) throws Exception {
		setModel(model);
		setPrice(price);
	}

	public Laptop(String model, String manufacturer, String processor,
			String ram, String graphicsCard, String hDD, String screen,
			Battery battery, float batteryLifeHours, double price)
			throws Exception {
		this(model, price);
		setManufacturer(manufacturer);
		setProcessor(processor);
		setRam(ram);
		setGraphicsCard(graphicsCard);
		setHDD(hDD);
		setScreen(screen);
		setBattery(battery);
		setBatteryLifeHours(batteryLifeHours);
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) throws Exception {
		if (model == null || model.trim().length() == 0) {
			throw new Exception();
		}
		this.model = model;
	}

	public String getManufacturer() {
		return manufacturer;
	}

	public void setManufacturer(String manufacturer) throws Exception {
		if (manufacturer == null || manufacturer.trim().length() == 0) {
			throw new Exception();
		}
		this.manufacturer = manufacturer;
	}

	public String getProcessor() {
		return processor;
	}

	public void setProcessor(String processor) throws Exception {
		if (processor == null || processor.trim().length() == 0) {
			throw new Exception();
		}
		this.processor = processor;
	}

	public String getRam() {
		return ram;
	}

	public void setRam(String ram) throws Exception {
		if (ram == null || ram.trim().length() == 0) {
			throw new Exception();
		}
		this.ram = ram;
	}

	public String getGraphicsCard() {
		return graphicsCard;
	}

	public void setGraphicsCard(String graphicsCard) throws Exception {
		if (graphicsCard == null || graphicsCard.trim().length() == 0) {
			throw new Exception();
		}
		this.graphicsCard = graphicsCard;
	}

	public String getHDD() {
		return hdd;
	}

	public void setHDD(String hDD) throws Exception {
		if (hDD == null || hDD.trim().length() == 0) {
			throw new Exception();
		}
		hdd = hDD;
	}

	public String getScreen() {
		return screen;
	}

	public void setScreen(String screen) throws Exception {
		if (screen == null || screen.trim().length() == 0) {
			throw new Exception();
		}
		this.screen = screen;
	}

	public Battery getBattery() {
		return battery;
	}

	public void setBattery(Battery battery) throws Exception {
		if (battery == null) {
			throw new Exception();
		}

		this.battery = battery;
	}

	public float getBatteryLifeHours() {
		return batteryLifeHours;
	}

	public void setBatteryLifeHours(float batteryLifeHours) throws Exception {
		if (batteryLifeHours < 0f) {
			throw new Exception();
		}

		this.batteryLifeHours = batteryLifeHours;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) throws Exception {
		if (batteryLifeHours < 0) {
			throw new Exception();
		}

		this.price = price;
	}

	public String toString() {
		return "Laptop [model=" + model + ", manufacturer=" + manufacturer
				+ ", processor=" + processor + ", ram=" + ram
				+ ", graphicsCard=" + graphicsCard + ", hdd=" + hdd
				+ ", screen=" + screen + ", battery=" + battery.toString()
				+ ", batteryLifeHours=" + batteryLifeHours + ", price=" + price
				+ "]";
	}

}
