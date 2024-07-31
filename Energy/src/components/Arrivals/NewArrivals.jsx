
import ArrivalsPhoto from './ArrivalsPhoto';
import ArrivalsText from './ArrivalsText';
import './NewArrivals.css';


const NewArrivals = () => {
    return (
      <div className="arrivals-carousel-container">
        <div className='arrivals-carousel'>
          <div className="arrivals-carousel-left-side">
            <ArrivalsText />
          </div>
          <div className="arrivals-carousel-right-side">
            <ArrivalsPhoto />
          </div>
        </div>
      </div>
    );
}


export default NewArrivals;