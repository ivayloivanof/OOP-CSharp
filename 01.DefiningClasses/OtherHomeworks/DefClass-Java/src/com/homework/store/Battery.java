package com.homework.store;

public class Battery {

	private String type;
	private int cells;
	private String ion;

	public Battery(String type, int cells, String ion) throws Exception {
		setType(type);
		setCells(cells);
		setIon(ion);
	}

	public String getType() {
		return type;
	}

	public void setType(String type) throws Exception {
		if(type == null || type.trim().length() == 0) {
			throw new Exception();
		}
		
		this.type = type;
	}

	public int getCells() {
		return cells;
	}

	public void setCells(int cells) throws Exception {
		if(cells < 1 ) {
			throw new Exception();
		}
		
		this.cells = cells;
	}

	public String getIon() {
		return ion;
	}

	public void setIon(String ion) throws Exception {
		if(ion == null || ion.trim().length() == 0) {
			throw new Exception();
		}
		
		this.ion = ion;
	}

	public String toString() {
		return  type + ", " + cells + "-cells, " + ion;
	}
	
}
