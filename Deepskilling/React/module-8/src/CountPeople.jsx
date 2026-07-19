import React from "react";

class CountPeople extends React.Component {

    constructor() {
        super();

        this.state = {
            entrycount: 0,
            exitcount: 0
        };
    }

    UpdateEntry = () => {
        this.setState((prevState) => ({
            entrycount: prevState.entrycount + 1
        }));
    };

    UpdateExit = () => {
        this.setState((prevState) => ({
            exitcount: prevState.exitcount + 1
        }));
    };

    render() {
        return (
            <div style={{ textAlign: "center", marginTop: "50px" }}>

                <button onClick={this.UpdateEntry}>
                    Login
                </button>

                <span style={{ marginLeft: "10px", marginRight: "50px" }}>
                    {this.state.entrycount} People Entered!!
                </span>

                <button onClick={this.UpdateExit}>
                    Exit
                </button>

                <span style={{ marginLeft: "10px" }}>
                    {this.state.exitcount} People Left!!
                </span>

            </div>
        );
    }
}

export default CountPeople;