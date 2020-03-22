import * as React from 'react';
import { connect } from 'react-redux';

const Edit = () => (
    (
        <form>
            <p className="h4 text-center mb-4">Edit User</p>
            <label className="grey-text">Phone Number</label>
            <input type="password" id="defaultFormLoginPasswordEx" className="form-control" />
            <div className="text-center mt-4">
            </div>
            <label className="grey-text">Duties</label>
            <input type="password" id="defaultFormLoginPasswordEx" className="form-control" />
            <div className="text-center mt-4">
            </div>
        </form>

    ));

export default connect()(Edit);