import React from 'react';
import { render, fireEvent, screen } from '@testing-library/react';
import App from './App';
 
describe('Addition Component', () => {
  test('Test Case 1: Addition of two positive numbers', () => {
    render(<App />);
    const input1 = screen.getByTestId('Textbox1');
    const input2 = screen.getByTestId('Textbox2');
    const addButton = screen.getByTestId('submit_button');
 
    fireEvent.change(input1, { target: { value: '5' } });
    fireEvent.change(input2, { target: { value: '3' } });
    fireEvent.click(addButton);
 
    const resultLabel = screen.getByText(/Result: 8/i);
    expect(resultLabel).toBeInTheDocument();
  });
 
  test('Test Case 2: Addition of a positive and a negative number', () => {
    render(<App />);
    const input1 = screen.getByTestId('Textbox1');
    const input2 = screen.getByTestId('Textbox2');
    const addButton = screen.getByTestId('submit_button');
 
    fireEvent.change(input1, { target: { value: '10' } });
    fireEvent.change(input2, { target: { value: '-2' } });
    fireEvent.click(addButton);
 
    const resultLabel = screen.getByText(/Result: 8/i);
    expect(resultLabel).toBeInTheDocument();
  });
 
  test('Test Case 3: Addition of two negative numbers', () => {
    render(<App />);
    const input1 = screen.getByTestId('Textbox1');
    const input2 = screen.getByTestId('Textbox2');
    const addButton = screen.getByTestId('submit_button');
 
    fireEvent.change(input1, { target: { value: '-5' } });
    fireEvent.change(input2, { target: { value: '-3' } });
    fireEvent.click(addButton);
 
    const resultLabel = screen.getByText(/Result: -8/i);
    expect(resultLabel).toBeInTheDocument();
  });
 
  test('Test Case 4: Addition with decimal numbers', () => {
    render(<App />);
    const input1 = screen.getByTestId('Textbox1');
    const input2 = screen.getByTestId('Textbox2');
    const addButton = screen.getByTestId('submit_button');
 
    fireEvent.change(input1, { target: { value: '3.14' } });
    fireEvent.change(input2, { target: { value: '2.72' } });
    fireEvent.click(addButton);
 
    const resultLabel = screen.getByText(/Result: 5.86/i);
    expect(resultLabel).toBeInTheDocument();
  });

  test('Test case-2[Render all lables and Text message', ()=>{
    render(<App/>);

    const heading = screen.getByTestId("Heading");
    const lable1 =  screen.getByTestId("SubHeading1");
    const lable2 =  screen.getByTestId("SubHeading2");

    const textbox1 = screen.getByTestId('Textbox1');
    const textbox2 = screen.getByTestId('Textbox2');

    const input1 = screen.getByTestId('Textbox1');
    const input2 = screen.getByTestId('Textbox2');
    const addButton = screen.getByTestId('submit_button');

    expect(textbox1).toHaveTextContent("");
    expect(textbox2).toHaveTextContent("");


    expect(heading).toBeInTheDocument();
    expect(heading).toHaveTextContent("Addition of two numbers");

    expect(lable1).toBeInTheDocument();
    expect(lable1).toHaveTextContent("Enter number 1");

    expect(lable2).toBeInTheDocument();
    expect(lable2).toHaveTextContent("Enter number 2");

    expect(addButton).toBeInTheDocument();
    expect(addButton).toHaveValue("Add");

    fireEvent.change(input1, { target: { value: '3.14' } });
    fireEvent.change(input2, { target: { value: '2.72' } });
    fireEvent.click(addButton);
 
    const resultLabel = screen.getByText(/Result: 5.86/i);
    expect(resultLabel).toBeInTheDocument();


    fireEvent.change(input1, { target: { value: '' } });
    fireEvent.change(input2, { target: { value: '' } });
    fireEvent.click(addButton);
 
    const resultLabel2 = screen.getByText(/Result: NaN/i);
    expect(resultLabel2).toBeInTheDocument();


  })
});