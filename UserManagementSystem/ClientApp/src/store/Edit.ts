import * as Edit from './Edit';

// The top-level state object
export interface ApplicationState {
    counter: Edit.ApplicationState | undefined;
}