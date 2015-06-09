package com.homework.person;

public class Person {

	private String name;
	private byte age;
	private String email;

	public Person(String name, byte age) throws Exception {
		this(name, age, null);
		setName(name);
		setAge(age);
	}

	public Person(String name, byte age, String email) throws Exception {
		setName(name);
		setAge(age);
		setEmail(email);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) throws Exception {
		if (name == null || name.trim().length() == 0) {
			throw new Exception("no name entered");
		}
		this.name = name;
	}

	public byte getAge() {
		return age;
	}

	public void setAge(byte age) throws Exception {
		if (age < 1 || age > 100) {
			throw new Exception("wrong age entered");
		}
		this.age = age;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) throws Exception {
		if (!isValidEmail(email)) {
			throw new Exception("wrong email entered");
		}
		this.email = email;
	}

	private boolean isValidEmail(String email) {
		for (int i = 0; i < email.length(); i++) {
			char current = email.charAt(i);
			if (current == '@') {
				if (i == email.length() - 1) {
					return false;
				}

				String beforeAt = email.substring(0, i);
				String afterAt = email.substring(i + 1, email.length());

				if (beforeAt.trim().length() > 0 && afterAt.trim().length() > 0) {
					return true;
				}
			}
		}

		return false;
	}

	public String toString() {
		return "Person [name=" + name + ", age=" + age + ", email=" + email
				+ "]";
	}
}
