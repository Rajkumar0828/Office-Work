import React from 'react';
import './App.css';
 
class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = { Num: '', Num2: '', Result: '' };
    this.handleAddition = this.handleAddition.bind(this);
  }
 
  handleAddition() {
    const num1 = parseFloat(this.state.Num);
    const num2 = parseFloat(this.state.Num2);
    const result = num1 + num2;
    this.setState({ Result: result });
  }
 
  render() {
    return (
      <div>
        <h1 data-testid="Heading"> Addition of two numbers </h1>
        <br></br>
        <label   data-testid="SubHeading1"> Enter number 1 </label>
        <input
          type="number"
          data-testid="Textbox1"
          value={this.state.Num}
          onChange={(e) => {
            this.setState({ Num: e.target.value });
          }}
        />
        <br></br>
        <label data-testid="SubHeading2"> Enter number 2 </label>
        <input
          type="number"
          data-testid="Textbox2"
          value={this.state.Num2}
          onChange={(e) => {
            this.setState({ Num2: e.target.value });
          }}
        />
        <br></br>
        <input type="button"  data-testid="submit_button" value="Add" onClick={this.handleAddition} />
        <br></br>
        <label>Result: {this.state.Result}</label>
      </div>
    );
  }
}
 
export default App;
 
 
 