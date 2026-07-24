import CalculateScore from "./Components/CalculateScore";

function App() {
    return (
        <div>
            <CalculateScore
                Name="Rudrakshi Bhagat"
                School="VFSTR"
                Total={450}
                Goal={5}
            />
        </div>
    );
}

export default App;