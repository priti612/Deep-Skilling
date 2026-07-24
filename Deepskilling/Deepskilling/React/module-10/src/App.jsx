import officeImg from "./assets/office.jpg";

function App() {

    const officeList = [
        {
            Name: "DBS",
            Rent: 50000,
            Address: "Chennai",
            Image: officeImg
        },
        {
            Name: "Infosys",
            Rent: 75000,
            Address: "Bangalore",
            Image: officeImg
        },
        {
            Name: "TCS",
            Rent: 55000,
            Address: "Hyderabad",
            Image: officeImg
        }
    ];

    return (
        <div style={{ marginLeft: "80px" }}>

            <h1>Office Space, at Affordable Range</h1>

            {
                officeList.map((office, index) => (

                    <div key={index} style={{ marginBottom: "30px" }}>

                        <img
                            src={office.Image}
                            alt="Office Space"
                            width="250"
                            height="250"
                        />

                        <h2>Name: {office.Name}</h2>

                        <h3
                            style={{
                                color:
                                    office.Rent < 60000
                                        ? "red"
                                        : "green"
                            }}
                        >
                            Rent: Rs. {office.Rent}
                        </h3>

                        <h3>Address: {office.Address}</h3>

                    </div>

                ))
            }

        </div>
    );
}

export default App;